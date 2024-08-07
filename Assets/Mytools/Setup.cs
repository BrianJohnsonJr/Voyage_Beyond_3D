using System;
using System.IO;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEditor.AssetDatabase;

public class Setup {

    [MenuItem("Tools/Setup/Create Default Folders")]
    public static void CreateDefaultFolders(){
        Folders.CreateDefault("_Project", "Animation", "Art", "Materials", "Prefabs", "ScriptableObjects", "Scripts", "Settings");
        UnityEditor.AssetDatabase.Refresh();
    }

    public static void ImportMyFavoriteAssets(){
        //Assets.ImportAsset();
    }

    static class Folders{
        public static void CreateDefault(string root, params string[] folders) {
            var fullpath = Path.Combine(Application.dataPath, root);
            foreach (var folder in folders){
                var path = Path.Combine(fullpath, folder);
                if(!Directory.Exists(path)){
                    Directory.CreateDirectory(path);
                }
            }
        }
    }

    static class Assets {
        public static void ImportAsset(string asset, string subfolder, string folder = "C:/Users/bj002/AppData/Roaming/Unity/Asset Store-5.x") {
            //AssetDatabase.ImportPackage(Combine(folder, subfolder, asset), false);
        }
    }
}