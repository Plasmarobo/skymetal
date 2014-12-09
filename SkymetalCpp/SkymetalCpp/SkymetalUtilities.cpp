


#include "SkymetalUtilities.h"

Vec3 Vec3::operator=(const Vec3 &rhs)
{
	this->X = rhs.X;
	this->Y = rhs.Y;
	this->Z = rhs.Z;
	return *this;
}
