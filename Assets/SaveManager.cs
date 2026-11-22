using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public static class SaveManager
{
    static string PathFile => Path.Combine(Application.persistentDataPath, "AlbamSongiRanking(Mobile).json");
    public static List<UserScore> GetTopScores(int count = 10)
    {
        SaveData data = Load();
        return data.users
            .OrderByDescending(x => x.point)
            .Take(count)
            .ToList();
    }
    public static SaveData Load()
    {
        if (!File.Exists(PathFile))
            return new SaveData();

        string json = File.ReadAllText(PathFile);
        return JsonUtility.FromJson<SaveData>(json) ?? new SaveData();
    }

    public static void Save(SaveData data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(PathFile, json);
    }

    public static int GetPoint(string id)
    {
        var data = Load();
        var user = data.users.FirstOrDefault(u => u.id == id);
        return user != null ? user.point : 0;
    }
    public static string GetCharater(string id)
    {
        var data = Load();
        var user = data.users.FirstOrDefault(u => u.id == id);
        return user != null ? user.ch : "??";
    }
    public static string GetTier(string id)
    {
        var data = Load();
        var user = data.users.FirstOrDefault(u => u.id == id);
        return user != null ? user.tier : "³ª¹«ÆÇ³Ú";
    }
    public static void SetScore(string id, string ch, int point, string tier)
    {
        var data = Load();
        var user = data.users.FirstOrDefault(u => u.id == id);

        if (user == null)
        {
            data.users.Add(new UserScore { id = id, point = point, tier = tier, ch = ch });
        }
        else
        {
            user.ch = ch;
            user.point = point;
            user.tier = tier;
        }

        Save(data);
    }
}
