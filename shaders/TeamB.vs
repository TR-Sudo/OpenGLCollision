#version 400
/*
* Simple vertex shader for point light source.
* Light source position in eye coordinates.
*/
in vec4 vPosition;
in vec3 vNormal;
uniform mat4 modelView;
uniform mat4 projection;
uniform mat3 normalMat;
out vec3 normal;
out vec4 position;
void main() {
gl_Position = projection * modelView * vPosition;
position = modelView * vPosition;
normal = normalMat* vNormal;
}