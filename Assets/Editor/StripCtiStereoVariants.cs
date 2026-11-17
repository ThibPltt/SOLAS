using System.Collections.Generic;
using UnityEditor.Build;
using UnityEditor.Rendering;
using UnityEngine;

// SOLAS is built with OpenXR in Multi-pass mode.
// The Forst tree shaders (CTI/...) fail to compile on GLES3 in their
// multiview / single-pass-instanced variants, which Multi-pass never uses,
// so those variants are removed from the build.
class StripCtiStereoVariants : IPreprocessShaders
{
    public int callbackOrder => 0;

    public void OnProcessShader(Shader shader, ShaderSnippetData snippet, IList<ShaderCompilerData> data)
    {
        if (!shader.name.StartsWith("CTI/"))
            return;

        for (int i = data.Count - 1; i >= 0; i--)
        {
            foreach (var keyword in data[i].shaderKeywordSet.GetShaderKeywords())
            {
                string name = keyword.name;
                if (name == "STEREO_MULTIVIEW_ON" || name == "STEREO_INSTANCING_ON")
                {
                    data.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
