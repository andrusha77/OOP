#include "Header.h"
#include "IntArray.h"

int main() {
	setlocale(LC_ALL, "ukr");
	int n;
	int k;
	int j;
	int count = 0;
	cout << "1 - Створити матрицю\n";
	cout << "0 - Вихід\n";
	
	cin >> k;
	switch (k)
	{
	case 1:
		cout << "Введіть розмір матриці (n x j): " << endl << "n = ";
		cin >> n;
		cout << "j = ";
		cin >> j;
		break;
	default:
		break;
	}
	IntMatrix arr(n, j);
	arr.input();
	count++;
	do {
		cout << "1 - вивести матрицю" << endl;
		cout << "2 - сума елементів i-го стовпця" << endl;
		cout << "3 - кількість нулів" << endl;
		cout << "4 - встановити діагональ" << endl;
		cout << "0 - вихід" << endl;
		cin >> k;
		switch (k)
		{
		case 1:
			arr.output();
			break;
		case 2: {
			int col;
			cout << "Введіть номер стовпця (1-" << n << "): ";
			cin >> col;
			cout << "Сума " << col << "-го стовпця: " << arr.sumOfColumn(col - 1) << endl;
			break;
		}
		case 3:
			cout << "Кількість нулів: " << arr.getZeroCount() << endl;
			break;
		case 4:
		{
			cout << "Введіть значення для діагоналі: ";
			int val;
			cin >> val;
			arr.setDiagonal(val);
			cout << "Після встановлення діагоналі:\n";
			arr.output();
			break;
		}
		default:
			break;
		}

	} while (k != 0);
	cout << "Завершення роботи програми." << endl;
	return 0;
}
