﻿Shader "Seerslab/UlitTexture" {
	Properties{
		_MainTex("Base (RGB)", 2D) = "white" {}
		
		
	}
		SubShader{
		Tags{ "RenderType" = "Transparent" "Queue" = "Transparent" }

		ZWrite Off

		Blend SrcAlpha OneMinusSrcAlpha
		ColorMask RGB

		Pass{
		SetTexture[_MainTex]{
		
		Combine texture , texture
	}	
	}
	}
}