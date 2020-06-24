#if UNITY_EDITOR
using UnityEditor;
using System.Diagnostics;
#endif
public class BuildScript
{
    public static void BuildGame()
    {
        // Get filename.
        string path = EditorUtility.SaveFolderPanel("build",
                                        "C:\\Users\aatao\\Desktop\\Blocks_Breaker\\Build",
                                         "build");

        string[] levels = new string[] { "Assets/Start Menu.unity", "Assets/Level 1.unity",
                                        "Assets/Level 2.unity", "Assets/Level 3.unity",
                                        "Assets/Level 4.unity", "Assets/Level 5.unity",
                                        "Assets/Game Over.unity"};

        // Build player.
        BuildPipeline.BuildPlayer(levels, path + "/BuiltGame.exe", BuildTarget.StandaloneWindows, BuildOptions.None);

        // Run the game (Process class from System.Diagnostics).
        Process proc = new Process();
        proc.StartInfo.FileName = path + "/BuiltGame.exe";
        proc.Start();
    }
}