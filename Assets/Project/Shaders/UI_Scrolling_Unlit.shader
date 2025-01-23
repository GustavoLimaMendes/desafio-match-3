Shader "GustavoLima_Shaders/UI_Scrolling_Unlit"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1) 
        _MainTex ("Albedo (RGB)", 2D) = "white" {} 
        _ScrollSpeedX ("Scroll Speed X", Float) = 0.1
        _ScrollSpeedY ("Scroll Speed Y", Float) = 0.1
    }
    SubShader
    {
        Tags { "Queue"="Transparent" "RenderType"="Transparent" "IgnoreProjector"="True" "CanUseSpriteAtlas"="True" }
        LOD 100

        Blend SrcAlpha OneMinusSrcAlpha 
        Cull Off
        ZWrite Off
        ZTest Always

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            sampler2D _MainTex; 
            fixed4 _Color;      
            float _ScrollSpeedX;
            float _ScrollSpeedY;

            struct appdata
            {
                float4 vertex : POSITION; 
                float2 texcoord : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0; 
                float4 vertex : SV_POSITION;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);

                float2 offset = float2((_ScrollSpeedX * _Time.y), (_ScrollSpeedY * _Time.y));
                o.uv = v.texcoord + offset;

                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 texColor = tex2D(_MainTex, i.uv) * _Color;
                return texColor;
            }
            ENDCG
        }
    }
    FallBack "Unlit/Transparent"
}
