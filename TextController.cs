using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	private enum States {synopsis, start, ludus, frobozz_0, doom_0, frobozz_1, doom_1, syrinx, anorak_temple, win};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.synopsis; 
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.synopsis)				{StateSynopsis ();}
		else if (myState == States.start)			{StateStart ();}
		else if (myState == States.ludus)			{StateLudus ();}
		else if (myState == States.frobozz_0)			{StateFrobozz_0 ();}
		else if (myState == States.doom_0)			{StateDoom_0 ();}
		else if (myState == States.frobozz_1)			{StateFrobozz_1 ();}
		else if (myState == States.doom_1)			{StateDoom_1 ();}
		else if (myState == States.syrinx)			{StateSyrinx ();}
		else if (myState == States.anorak_temple)		{StateAnorakTemple ();}
		else if (myState == States.win)				{StateWin ();}
	}
	
	void StateSynopsis (){
		text.text = "This is the last game created by James Halliday before\n" +
					"he died in an attempt to find an heir for his vast fortune and pass\n" +
					"ownership of the OASIS simulation to someone worthy.\n" +
					"In order to find the Easter Egg, people would need to\n" +
					"find three keys and open three gates scattered throughout the OASIS.\n" +
					"     Three hidden keys open three secret gates\n" +
					"     Wherein the errant will be tested for worthy traits\n" +
					"     And those with the skill to survive these straits\n" +
					"     Will reach The End where the prize awaits.\n\n" + 
					"Press S to start Hunt.";
		if (Input.GetKeyDown (KeyCode.S))			{myState = States.start;}
	}
	
	void StateStart (){
		text.text = "Here is your first hint:\n" + 
					"     The Copper Key awaits explorers\n" +
					"     In a tomb filled with horrors\n" +
					"     But you have much to learn\n" +
					"     If you hope to earn\n" +
					"     A place among the high scorers\n\n" +
					"Press F to go on Frobozz planet, L to go on Ludus planet, to go on Doom planet.";
		if (Input.GetKeyDown (KeyCode.F))			{myState = States.frobozz_0;}
		else if (Input.GetKeyDown (KeyCode.L))			{myState = States.ludus;}
		else if (Input.GetKeyDown (KeyCode.D))			{myState = States.doom_0;}
	}
	
	void StateFrobozz_0 (){
		text.text = "You are on Frobozz planet.\n" + 
					"It contains hundreds of individual 3D versions of the game ZORK.\n" + 
					"There is no key on the planet.\n\n" + 
					"Press R to return.";
		if (Input.GetKeyDown (KeyCode.R))			{myState = States.start;}
	}
	
	void StateLudus (){
		text.text = "You are on Ludus planet.\n" + 
					"It is a non-PVP zone and home to hundreds of public schools are found\n" + 
					"You find Tomb of Horrors! The Copper key is yours. Here is your second hint:\n\n" +
					"     Continue your quest by taking the test.\n\n" +
					"Let's find next Jade key!\n\n" +
					"Press F to go on Frobozz planet, press D to go on Doom planet.";
		if (Input.GetKeyDown (KeyCode.F))			{myState = States.frobozz_1;}
		else if (Input.GetKeyDown (KeyCode.D))			{myState = States.doom_1;}
	}
	
	void StateDoom_0 (){
		text.text = "You are on Doom planet.\n" + 
					"This is one of the planets of the Drule Empire.\n" + 
					"There is no key on the planet.\n\n" + 
					"Press R to return.";
		if (Input.GetKeyDown (KeyCode.R))			{myState = States.start;}
	}
	
	void StateFrobozz_1 (){
		text.text = "You are on Frobozz planet.\n" + 
					"You collect each of Zork's 19 treasures\n" +
					"and place them in the trophy case of the white house.\n" +
					"You earned the Jade Key.\n\n" +
					"     We are the Priests of the Temples of Syrinx\n" +
					"     Our great computers fill the hallowed halls.\n" +
					"     We are the Priests of the Temples of Syrinx\n" +
					"     All the gifts of life are held within our walls.\n\n" +				
					"Press S to go to Syrinx planet";
		if (Input.GetKeyDown (KeyCode.S))			{myState = States.syrinx;}
	}
	
	void StateDoom_1 (){
		text.text = "You are on Doom planet.\n" + 
					"There is no key on the planet.\n\n" + 
					"Press R to return.";
		if (Input.GetKeyDown (KeyCode.R))			{myState = States.ludus;}
	}
	
	void StateSyrinx (){
		text.text = "You are on Syrinx planet.\n" + 
					"You earned last hint:\n\n" +
					"     The first was ringed in red metal\n" +
  					"     The second, in green stone\n" +
  					"     The third is clearest crystal\n" +
  					"     and cannot be unlocked alone\n\n" +
					"Press A to go to Anorak's Temple to receive Easter Egg.";
		if (Input.GetKeyDown (KeyCode.A))			{myState = States.anorak_temple;}
	}
	
	void StateAnorakTemple (){
		text.text = "You are in front of Anorak's Temple.\n" + 
					"You and two you friends open Temple and receive the Easter Egg.\n" +
					"OASIS simulation is now yours. Act wisely.\n\n" +
					"Press T to take the Easter Egg.";
		if (Input.GetKeyDown (KeyCode.T))			{myState = States.win;}
	}
	
	void StateWin (){
		text.text = "Congratulations! You win!\n\n" +
					"Press P to play again.";
		if (Input.GetKeyDown (KeyCode.P))			{myState = States.synopsis;}
	}	
}
