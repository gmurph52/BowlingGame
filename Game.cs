using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ScoringBowling
{
	public class Game
	{
		public Game()
		{
			Frames = new Frame[10];
			for (int i = 0; i < Frames.Length; i++)
			{
				var frame = new Frame();
				Frames[i] = frame;
			}
		}

		private int _currentFrame = 0;
		public Frame[] Frames { get; set; }

		public void Roll(int pins)
		{
			var currentFrame = Frames[_currentFrame];

			// if already has 2 roles
			// add new frame 
			if (currentFrame.Roll1 == null)
			{
				currentFrame.Roll1 = pins;
			} 
			//else if (currentFrame.Roll2)


			//if  Roll1 is null
			// Rol! = pins 
			// else if Roll2 is null
			// Rol2 = pins 
			// else if frame [9] and Roll3 isnull
			// role3 = pins


		}

		public int Score()
		{
			int scoreTotal = 0;
            foreach (var frame in Frames)
            {
	            var frameTotal = frame.Roll1 + frame.Roll2 + frame.Roll3;

	            scoreTotal += frameTotal;
            }

			return scoreTotal;
		}
	}
}
