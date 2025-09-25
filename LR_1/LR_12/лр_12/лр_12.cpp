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
		cout << "5 - інкремент" << endl;
		cout << "6 - декремент" << endl;
		cout << "7 - перевірка чи матриця квадратна" << endl;
		cout << "8 - додавання матриць" << endl;
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
		case 5:
			++arr;
			cout << "Після інкременту:\n";
			arr.output();
			break;
		case 6:
			--arr;
			cout << "Після декременту:\n";
			arr.output();
			break;
		case 7:
			if (arr) {
				cout << "Матриця є квадратною." << endl;
			}
			else {
				cout << "Матриця не є квадратною." << endl;
			}
			break;
		case 8:
			if (count == 0) {
				cout << "Спочатку створіть першу матрицю." << endl;
				break;
			}
			else {
				int n2, j2;
				cout << "Введіть розмір другої матриці (n x j): " << endl << "n = ";
				cin >> n2;
				cout << "j = ";
				cin >> j2;
				if (n2 != n || j2 != j) {
					cout << "Матриці повинні бути однакового розміру для додавання." << endl;
					break;
				}
				IntMatrix arr2(n2, j2);
				arr2.input();
				IntMatrix arrSum = arr + arr2;
				cout << "Результат додавання:\n";
				arrSum.output();
				
			}
			break;
		default:
			break;
		}

	} while (k != 0);
	cout << "Завершення роботи програми." << endl;
	return 0;
}
