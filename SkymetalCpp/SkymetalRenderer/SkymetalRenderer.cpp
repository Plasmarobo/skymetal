// This is the main DLL file.

#include "SkymetalUtilities.h"
#include "SkymetalRenderer.h"

namespace SkymetalRenderer
{

	class Shader;
	class Quad;
	class Camera;
	class Scene;
	class Renderer;

	class Shader
	{
	protected:
		char *m_fileName;
	public:
		Shader();
	};

	class Quad
	{
	protected:
		Rect m_area;
		double m_angle;

		
	};

	class Camera
	{

	};

	class Scene
	{

	};

	class Renderer
	{
	protected:
		SDL_Window *m_window;
		SDL_Surface *m_surface;
	public:
		Renderer();
	};
};