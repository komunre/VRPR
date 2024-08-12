Shader "CustomRenderTexture/Monocular Circular Shader"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex("InputTex", 2D) = "white" {}
     }

     SubShader
     {
        Blend One Zero

        Pass
        {
            Name "Monocular Circular Shader"

            CGPROGRAM
            #include "UnityCustomRenderTexture.cginc"
            #pragma vertex CustomRenderTextureVertexShader
            #pragma fragment frag
            #pragma target 3.0

            float4      _Color;
            sampler2D   _MainTex;

            float4 frag(v2f_customrendertexture IN) : SV_Target
            {
                float2 uv = IN.localTexcoord.xy;
                float4 color = tex2D(_MainTex, uv) * _Color;

                float cirx = cos(IN.localTexcoord.x);
                float ciry = sin(IN.localTexcoord.y);

                if (cirx > 0.8 || ciry > 0.8) {
                    discard;
                }

                // TODO: Replace this by actual code!
                uint2 p = uv.xy * 256;
                return countbits(~(p.x & p.y) + 1) % 2 * float4(uv, 1, 1) * color;
            }
            ENDCG
        }
    }
}
