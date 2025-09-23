#include "header.h"
class IntMatrix {
private:

    int** IntArray;
    int n;
    int j;
public:

    IntMatrix(int size1, int size2) {

        n = size1;
        j = size2;
        IntArray = new int* [n];
        for (int i = 0; i < n; i++) {
            IntArray[i] = new int[j];
            for (int l = 0; l < n;l++) {
                IntArray[i][l] = 0;
            }
        }
    }
	

    ~IntMatrix() {
        for (int i = 0; i < n; i++) {
            delete[] IntArray[i];
        }
        delete[] IntArray;
    }


    void input() {
        cout << "¬вед≥ть елементи матриц≥ " << n << "x" << j << ":\n";
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
				cout << i * j + 1 << " елемент: ";
                cin >> IntArray[i][j];
            }
        }
    }


    void output() {
        cout << "ћатриц€:\n";
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                cout << IntArray[i][j] << "\t";
            }
            cout << endl;
        }
    }


    int sumOfColumn(int col) {
        if (col < 0 || col >= n) {
            cout << "Ќекоректний номер стовпц€!\n";
            return 0;
        }
        int sum = 0;
        for (int i = 0; i < n; i++) {
            sum += IntArray[i][col];
        }
        return sum;
    }


    int getZeroCount() {
        int count = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (IntArray[i][j] == 0) count++;
            }
        }
        return count;
    }


    void setDiagonal(int scalar) {
        for (int i = 0; i < n; i++) {
            IntArray[i][i] = scalar;
        }
    }

    IntMatrix& operator++() {
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                IntArray[i][j]++;
        return *this;
    }
	IntMatrix operator++(int) {
		IntMatrix temp = *this;
		++(*this);
		return temp;
	}
    IntMatrix& operator--() {
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                IntArray[i][j]--;
        return *this;
    }
    IntMatrix operator--(int) {
        IntMatrix temp = *this;
        --(*this);
        return temp;
    }
	operator bool() const {
        return n == j;
	}
	IntMatrix operator+(const IntMatrix& other) {
		if (n != other.n || j != other.j) {
			throw invalid_argument("Matrices must have the same dimensions for addition.");
		}
		IntMatrix result(n, j);
		for (int i = 0; i < n; i++) {
			for (int k = 0; k < j; k++) {
				result.IntArray[i][k] = IntArray[i][k] + other.IntArray[i][k];
			}
		}
		return result;
	}
};