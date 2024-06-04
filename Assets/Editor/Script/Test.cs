#if UNITY_EDITOR
using UnityEditor;
#endif
public static class Test
{
#if UNITY_EDITOR
    public static void Build_test()
    {
        string[] sceneList = { "./Assets/Scenes/Main_Game.unity" };

        BuildPipeline.BuildPlayer(sceneList, "C:/work/Jenkins_test/test.exe", BuildTarget.StandaloneWindows64, BuildOptions.Development);
    }
#endif
}

