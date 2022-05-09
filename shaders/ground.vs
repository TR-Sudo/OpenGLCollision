#version 400
/*
* Simple vertex shader for directional light
*/
in vec4 vPosition;
in vec3 vNormal;
uniform mat4 modelView;
uniform mat4 projection;
uniform mat3 normalMat;
out vec3 normal;
out float yDepth;
out vec4 position;
void main() {
gl_Position = projection * modelView * vPosition;
normal = normalMat* vNormal;
yDepth = vPosition.y;//passing height
position = modelView * vPosition;
}
