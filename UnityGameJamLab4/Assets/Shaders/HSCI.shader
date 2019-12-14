Shader "Hidden/HSCI"
{
	SubShader
	{
		// No culling or depth
		Cull Off ZWrite Off ZTest Always

		Pass
		{
			HLSLPROGRAM
			#pragma vertex VertDefault
			#pragma fragment Frag
			#include "Packages/com.unity.postprocessing/PostProcessing/Shaders/StdLib.hlsl"

			uniform sampler2D _MainTex;

			uniform float _Power;
			uniform float _Hue;
			uniform float _Saturation;
			uniform float _Contrast;
			uniform float _Invert;

			float4 Frag(VaryingsDefault i) : SV_Target
			{
				float4 cola = tex2D(_MainTex, i.texcoord + float2(_Power,0));
				float4 colb = tex2D(_MainTex, i.texcoord + float2(-_Power,0));
				// TODO: HSL stuff

				return lerp(cola , colb, 0.5f);
			}
			ENDHLSL
		}
	}
}