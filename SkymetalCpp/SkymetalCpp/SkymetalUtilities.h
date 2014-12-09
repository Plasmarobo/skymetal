
#ifndef SKYMETALUTILITIES_H
#define SKYMETALUTILITIES_H
class Vec3;
class Rect;

class Vec3
{
public:
	double X;
	double Y;
	double Z;

	Vec3() { X = Y = Z = 0.0; }
	Vec3(double x, double y, double z) { X = x; Y = y; Z = z; }
	Vec3(const Vec3 &rhs) { *this = rhs; }
	Vec3 operator=(const Vec3 &rhs);
	Vec3 operator+(const Vec3 &rhs);
	Vec3 operator-(const Vec3 &rhs);
	Vec3 operator+=(const Vec3 &rhs);
	Vec3 operator-=(const Vec3 &rhs);

	Vec3 operator*(const Vec3 &rhs); //Cross product
	Vec3 dot(const Vec3 &rhs);
	
};

class Rect
{
public:
	double X;
	double Y;
	double W;
	double H;

	Rect() { X = Y = W = H = 0.0; }
	Rect(double x, double y, double w, double h) { X = x; Y = y; W = w; H = h; }
	Rect(const Rect &rhs) { *this = rhs; }
	Rect operator=(const Rect &rhs);
}; 
#endif