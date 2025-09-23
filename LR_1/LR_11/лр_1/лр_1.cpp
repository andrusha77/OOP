
#include <iostream>
#include "Header.h"
void print(ispit obj) {
	obj.print();
}
int main()
{
	setlocale(LC_ALL, "ukr");
	ispit chel;
	ispit *chell;
	chell = new ispit;
	ispit spisok[3];
	chel.setperson("Andrusha", 20230610, 5);
	chel.print();
	chell->setperson("Sasha", 20230611, 4);
	chell->print();
	spisok[0] = chel;
	spisok[1] = *chell;
	ispit chel2;
	chel2.set_name_student("Illa");
	chel2.set_data(20230612);
	chel2.set_mark(3);
	cout << endl;
	spisok[2] = chel2;
	for (int i = 0; i < 3; i++) {
		spisok[i].print();
		cout << endl;
	}
	return 0;

}

