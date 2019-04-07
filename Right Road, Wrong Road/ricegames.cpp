#include <iostream>
#include <cstdlib>
#include <cctype>
#include <algorithm>
using namespace std;


int main()
{
	int lives = 5;
	int turns = 1;
	string playerName;
	string playerChoice;
	string demonSide;
	
	cout << "Right Road, Wrong Road!\n";
	cout << "You are chasing a demon who risks everything to eat humans. You must choose the correct side or else the demon eats some humans.\n";
	cout << "What's your name?\n"; cin >> playerName;

	while (lives > 0) {
		cout << "Turn: " << turns << ". Lives = " << lives << ". Left or Right?\n"; cin >> playerChoice;
		int demonChoice = rand() % 2;
		if (demonChoice == 0) {
			demonSide = "Left";
		}
		else {
			demonSide = "Right";
		}
		transform(playerChoice.begin(), playerChoice.end(), playerChoice.begin(), ::tolower);
		transform(demonSide.begin(), demonSide.end(), demonSide.begin(), ::tolower);
		if (playerChoice == demonSide) {
			cout << "Awesome! You stopped the demon... for now... Lives = " << lives << ".\n";
			turns += 1;
		}
		else if (playerChoice != demonSide && playerChoice == "left" || playerChoice == "right") {
			lives -= 1;
			turns += 1;
			cout << "Whoops! The demon ate humans in another town. You lost a life. Lives = " << lives << ".\n";
		}
		else {
			cout << "Whoops! Try again!\n";
		}
	}
	if (turns > 19){
		cout << "You ran out of lives. " << playerName << ", you were able to live for " << turns << " turns. Rating = S\n";
	}
	else if (turns > 14 && turns < 20){
		cout << "You ran out of lives. " << playerName << ", you were able to live for " << turns << " turns. Rating = A\n";
	}
	else if (turns > 11 && turns < 15){
		cout << "You ran out of lives. " << playerName << ", you were able to live for " << turns << " turns. Rating = B\n";
	}
	else if (turns > 9 && turns < 12){
		cout << "You ran out of lives. " << playerName << ", you were able to live for " << turns << " turns. Rating = C\n";
	}
	else if (turns > 5 && turns < 10) {
		cout << "You ran out of lives. " << playerName << ", you were able to live for " << turns << " turns. Rating = D\n";
	}
	else{
		cout << "You ran out of lives. " << playerName << ", you were able to live for " << turns << " turns. Rating = F\n";
	}
	return 0;
}