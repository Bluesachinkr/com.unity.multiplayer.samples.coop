using UnityEditor;

public class BuildScript
{
    public static void BuildLinuxServer()
    {
        var options = new BuildPlayerOptions
        {
            scenes = EditorBuildSettings.scenes,
            locationPathName = "build/LinuxServer/BossRoom.x86_64",
            target = BuildTarget.StandaloneLinux64,
            subtarget = (int)StandaloneBuildSubtarget.Server,
            options = BuildOptions.EnableHeadlessMode
        };

        BuildPipeline.BuildPlayer(options);
    }
}
