using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManger
{
    public static string username;
    public static int score;
    public static int recentscore;
    public static string useremail;
   

    public static bool LoggedIn { get { return username != null; } } //if username doesnt exists , it will return false so that will tell us that the user hasn't logged in

    public static void LogOut()
    {
        username = null;
    }
}