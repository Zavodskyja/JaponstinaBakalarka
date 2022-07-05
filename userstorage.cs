using Japonstina.models;
using System.Collections.Generic;
using System.Linq;

public static class userstorage
{
    public static List<usermodel> UserList = new List<usermodel>();


    public static void adduser(usermodel usermodel)
    {
        UserList.Add(usermodel);
    }

    public static bool login(usermodel usermodel)
    {
        var exists = UserList.Any(user => user.username == usermodel.username && user.password == usermodel.password);
        return exists;
    }
    public static bool exist(string username)
    {
        var exists = UserList.Any(user => user.username == username);
        return exists;
    }
}