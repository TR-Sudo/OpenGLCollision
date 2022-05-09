#version 400
/*
* A simple fragment shader for directional light
*/
in vec3 normal;
in vec4 position;
in float yDepth;
out vec4 color;
void main()
{
    vec3 lightColor=vec3(1.0,1.0,1.0);//light colors white
    vec3 posxyz=position.xyz;

    float ambientStrength = 0.1;
    vec3 ambient = ambientStrength * lightColor;//ambient
    vec3 N = normalize(normal);//N

    vec3 L = normalize(vec3(2, 0, -5) - posxyz);//L
    vec3 R = normalize(reflect(-L, N));//R

    float diff = max(dot(N,L), 0.0);//diffuse 
    vec3 diffuse = diff * lightColor;
    
    if(yDepth==0){//ground levels
    color=min(vec4(ambient,1.0)+vec4(diffuse,1.0),vec4(1.0))*vec4(0.502f,0.502f,0.502f, 1.0f);
    }
    if(yDepth>0 ){
    color=min(vec4(ambient,1.0)+vec4(diffuse,1.0),vec4(1.0))*vec4(0.349f,0.349f,0.349f, 1.0f); 
    }
}
