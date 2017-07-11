/*
 * Author:  Rick
 * Create:  2017/7/11 15:30:18
 * Email:   rickjiangshu@gmail.com
 * Follow:  https://github.com/RickJiangShu
 */
using UnityEngine;
using UnityEditor;

/// <summary>
/// TestBuild
/// </summary>
public class TestBuild : ScriptableObject
{
    [MenuItem("Test/Build")]
    public static void Build()
    {
        BuildTarget targetPlatform = BuildTarget.StandaloneWindows;
#if UNITY_ANDROID
        targetPlatform = BuildTarget.Android;
#elif UNITY_IPHONE
        targetPlatform = BuildTarget.iOS;
#elif UNITY_STANDALONE_WIN
        targetPlatform = BuildTarget.StandaloneWindows;
#endif

        BuildPipeline.BuildAssetBundles(Application.streamingAssetsPath, BuildAssetBundleOptions.None, targetPlatform);
        AssetDatabase.Refresh();

        Debug.Log("Asset Bundle打包完成！");
    }
}