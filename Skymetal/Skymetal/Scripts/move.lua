if (math.abs(event.x) > math.abs(event.y))
{
  if(event.x > 0)
  {
    self.mAnimationState = "right";
  }
  else if (event.x < 0)
  {
    self.mAnimationState = "left";
  }
}
else
{
  if(event.y > 0)
  {
    self.mAnimationState = "down";
  }
  else if (event.y < 0)
  {
    self.mAnimationState = "up";
  }
  else
  {
    self.mAnimationState = "idle";
  }
}

self.mPosition.x += event.x;
self.mPosition.y += event.y;