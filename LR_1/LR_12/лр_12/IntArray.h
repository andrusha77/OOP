#include "header.h"
class IntMatrix {
private:

    int** IntArray;
    int len;
    int hig;
public:

    IntMatrix(int size1, int size2) {

        len = size1;
        hig = size2;
        IntArray = new int* [hig];
        for (int i = 0; i < hig; i++) {
            IntArray[i] = new int[len];
            for (int l = 0; l < len;l++) {
                IntArray[i][l] = 0;
            }
        }
    }
	

    ~IntMatrix() {
        for (int i = 0; i < len; i++) {
            delete[] IntArray[i];
        }
        delete[] IntArray;
    }


    void input() {
        cout << "¬вед≥ть елементи матриц≥ " << len << "x" << hig << ":\n";
        for (int i = 0; i < hig; i++) {
            for (int j = 0; j < len; j++) {
				cout << (i+1) * (j+1) << " елемент: ";
                cin >> IntArray[i][j];
            }
        }
    }


    void output() {
        cout << "ћатриц€:\n";
        for (int i = 0; i < hig; i++) {
            for (int j = 0; j < len; j++) {
                cout << IntArray[i][j] << "\t";
            }
            cout << endl;
        }
    }


    int sumOfColumn(int col) {
        if (col < 0 || col >= hig) {
            cout << "Ќекоректний номер стовпц€!\n";
            return 0;
        }
        int sum = 0;
        for (int i = 0; i < hig; i++) {
            sum += IntArray[i][col];
        }
        return sum;
    }


    int getZeroCount() {
        int count = 0;
        for (int i = 0; i < hig; i++) {
            for (int j = 0; j < len; j++) {
                if (IntArray[i][j] == 0) count++;
            }
        }
        return count;
    }


    void setDiagonal(int scalar) {
        for (int i = 0; i < hig; i++) {
            IntArray[i][i] = scalar;
        }
    }

    IntMatrix& operator++() {
        for (int i = 0; i < hig; i++)
            for (int j = 0; j < len; j++)
                IntArray[i][j]++;
        return *this;
    }
	IntMatrix operator++(int) {
		IntMatrix temp = *this;
		++(*this);
		return temp;
	}
    IntMatrix& operator--() {
        for (int i = 0; i < hig; i++)
            for (int j = 0; j < len; j++)
                IntArray[i][j]--;
        return *this;
    }
    IntMatrix operator--(int) {
        IntMatrix temp = *this;
        --(*this);
        return temp;
    }
	operator bool() const {
        return len == hig;
	}
	IntMatrix operator+(const IntMatrix& other) {
        IntMatrix result(len, hig);
        cout << len << endl << hig << endl << endl;
		for (int i = 0; i < hig; i++) {
			for (int k = 0; k < len; k++) {
				result.IntArray[i][k] = IntArray[i][k] + other.IntArray[i][k];
			}
		}
		return result;
	}
};