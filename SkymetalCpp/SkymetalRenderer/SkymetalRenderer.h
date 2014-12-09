// SkymetalRenderer.h

#ifndef SKYMETALRENDERER_H
#define SKYMETALRENDERER_H

#include <SDL.h>

namespace SkymetalRenderer {


	public ref class Shader
	{
	protected:
		char *m_fileName;
	public:
		Shader();
	};

	public ref class Quad
	{
	protected:
		Shader m_shader;

	};

	public ref class Camera
	{

	};

	public ref class Scene
	{

	};

	public ref class Renderer
	{
	protected:
		SDL_Window *m_window;
		SDL_Renderer *m_renderer;
		SDL_GLContext *m_GLContext;
		unsigned int m_screenWidth;
		unsigned int m_screenHeight;
	};
}

#endif