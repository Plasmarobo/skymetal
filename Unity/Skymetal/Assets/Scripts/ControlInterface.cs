//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
namespace AssemblyCSharp
{
	enum Actions {
	MoveNorth = 0,
	MoveEast,
	MoveSouth,
	MoveWest,
	FaceNorth,
	FaceEast,
	FaceSouth,
	FaceWest,
	Pickup,
	UseWorld,
	UseEquipped,
	UseItem,
	Idle,
	}

	public interface Controlable
	{
		void MoveNorth ();

		void MoveSouth ();

		void MoveEast ();

		void MoveWest ();

		void Pickup ();

		void UseWorld ();

		void UseEquipped ();

		void UseItem ();

		void Idle();

		void Face();

		bool IsMoving();

		int GetFacing();

		void SubmitAction(int action);

	}

	public class Controller
	{
		protected void North()
		{
			mActionStream.push (Actions::North);
		}
		protected void East()
		{
			mActionStream.push (Actions::East);
		}

		protected void South()
		{
			mActionStream.push (Actions::South);
		}
		protected void West()
		{
			mActionStream.push (Actions::West);
		}

		protected void Use()
		{
			mActionStream.push (Actions::UseWorld);
		}

		protected void Fire()
		{
			mActionStream.push (Actions::UseEquipped);
		}
		protected void Item()
		{
			mActionStream.push (Actions::UseItem);
		}

		protected void Select(){mActionStream.push (Actions::Idle);}

		Controlable mTarget;
		Queue<int> mActionStream;

		public void SetTarget(Controlable target);
		public int GetNextAction()
		{
			return mActionStream.pop ();
		}

		public Controller()
		{
			mActionStream = new Queue<int> ();

		}
	}
}
