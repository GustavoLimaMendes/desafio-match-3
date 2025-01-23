Shader "GustavoLima_Shaders/UI_Particle_Unlit"
{
    Properties
   {
      [HDR] _Color ("Color", Color) = (1,1,1,1)
      _MainTex ("Albedo (RGB)", 2D) = "white" {}
      _Transparency("Transparency", Range(0,1)) = 0.1
   } 
   SubShader
   {
       Tags { "RenderType"="Transparent" }
       LOD 200

       CGPROGRAM    

       #pragma surface surf Standard alpha:fade
       //#pragma target 2.5
       #pragma target 4.5
       #pragma exclude_renderers gles gles3 glcore metal

       sampler2D _MainTex;

       struct Input
       {
           float2 uv_MainTex;
           float4 color : COLOR;
       };

       fixed4 _Color;
       float _Transparency;

       void surf (Input IN, inout SurfaceOutputStandard o)
       {
          fixed4 texColor = tex2D(_MainTex, IN.uv_MainTex);
          fixed4 c = texColor * _Color * IN.color;
          o.Albedo = c.rgb;
          o.Alpha = c.a * _Transparency; 
       }

       ENDCG
   }
   FallBack "Diffuse"
}
