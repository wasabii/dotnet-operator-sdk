namespace KubeOps.Cli.Output;

internal enum OutputFormat
{
    /// <summary>
    /// Format the output in Kubernetes YAML style.
    /// </summary>
    Yaml,

    /// <summary>
    /// Format the output in Kubernetes JSON style.
    /// </summary>
    Json,

    /// <summary>
    /// Format the output in plain text style.
    /// </summary>
    Plain,
}

internal static class OutputFormatExtensions
{
    public static string GetFileExtension(this OutputFormat format) => format switch
    {
        OutputFormat.Yaml => "yaml",
        OutputFormat.Json => "json",
        _ => string.Empty,
    };
}
