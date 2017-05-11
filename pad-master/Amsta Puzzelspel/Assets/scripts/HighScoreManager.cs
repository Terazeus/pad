using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System;

public class HighScoreManager : MonoBehaviour
{

    private string connectionString;

    private List<Highscore> highScores = new List<Highscore>();

    public GameObject scorePrefab;

    public Transform scoreParent;

    public int topRanks;

    public int saveScores;

    // Use this for initialization
    void Start()
    {

        connectionString = "URI=file:" + Application.dataPath + "/HighScoreDB.sqlite";

        CreateTable();

        DeleteExtraScore();

        ShowScores();
    }   

    // Update is called once per frame
    void Update()
    {

    }

    private void CreateTable()
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = String.Format("CREATE TABLE if not exists HighScores (ID INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL  UNIQUE , Player TEXT NOT NULL , Score INTEGER NOT NULL , Date DATETIME NOT NULL  DEFAULT CURRENT_DATE)");

                dbCmd.CommandText = sqlQuery;

                dbCmd.ExecuteScalar();

                dbConnection.Close();
            }
        }
    }


    private void InsertScore(string player, int newScore)
    {
        GetScores(); 

        int hsCount = highScores.Count; 

        if (highScores.Count > 0) 
        {
            Highscore lowestScore = highScores[highScores.Count - 1]; 

            if (lowestScore != null && saveScores > 0 && highScores.Count >= saveScores && newScore > lowestScore.Score)
            {
                DeleteScore(lowestScore.ID);

                hsCount--; 
            }
        }
        if (hsCount < saveScores) 
        {
            using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();

                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    string sqlQuery = String.Format("INSERT INTO Highscores(Player,Score) VALUES(\"{0}\",\"{1}\")", player, newScore);

                    dbCmd.CommandText = sqlQuery;
                    dbCmd.ExecuteScalar(); 
                    dbConnection.Close();


                }
            }
        }
    }

    private void GetScores()
    {
        highScores.Clear();

        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT * FROM Highscores";

                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        highScores.Add(new Highscore(reader.GetInt32(0), reader.GetInt32(2), reader.GetString(1), reader.GetDateTime(3)));
                    }

                    dbConnection.Close();
                    reader.Close();
                }
            }
        }

        highScores.Sort();
    }

    private void DeleteScore(int id)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = String.Format("DELETE FROM Highscores WHERE ID = \"{0}\"", id);

                dbCmd.CommandText = sqlQuery;
                dbCmd.ExecuteScalar();
                dbConnection.Close();

            }
        }
    }

    private void ShowScores()
    {
        GetScores();

        for (int i = 0; i < topRanks; i++)
        {
            if (i <= highScores.Count - 1)
            {
                GameObject tmpObjec = Instantiate(scorePrefab);

                Highscore tmpScore = highScores[i];

                tmpObjec.GetComponent<HighScoreScript>().SetScore(tmpScore.Name, tmpScore.Score.ToString(), "#" + (i + 1).ToString());

                tmpObjec.transform.SetParent(scoreParent);

                tmpObjec.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            }

        }
    }

    private void DeleteExtraScore()
    {
        GetScores();
        if (saveScores <= highScores.Count)
        {
            int deleteCount = highScores.Count - saveScores;
            highScores.Reverse();

            using (IDbConnection dbConnection = new SqliteConnection(connectionString))
            {
                dbConnection.Open();

                using (IDbCommand dbCmd = dbConnection.CreateCommand())
                {
                    for (int i = 0; i < deleteCount; i++)
                    {   

                        string sqlQuery = String.Format("DELETE FROM Highscores WHERE ID = \"{0}\"", highScores[i].ID);

                        dbCmd.CommandText = sqlQuery;
                        dbCmd.ExecuteScalar();
                        dbConnection.Close();
                    }
                    dbConnection.Close();
                }
            }
        }
    } 
}
