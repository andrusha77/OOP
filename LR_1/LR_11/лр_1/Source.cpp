#include "Header.h"
#include <iomanip>

ispit::ispit() :name_student("gg"), data(0), mark(0) {

	cout << "��������� ����������� �� �������: " << this << endl;
}
ispit::ispit(string n, int d, int m) :name_student(n), data(d), mark(m) {
	cout << "��������� ����������� � ����������� �� �������: " << this << endl;

}

ispit::ispit(const ispit&) {

	cout << "��������� ����������� ���i������ �� �������:" << this << endl;
};
ispit::~ispit(void) {
	cout << "��������� ���������� �� �������:" << this << endl;
}
void ispit::set_name_student(string n) {
	name_student = n;
}
void ispit::set_data(int d) {
	data = d;
}
void ispit::set_mark(int m) {
	mark = m;
}
void ispit::setperson(string n, int d, int m) {
	name_student = n;
	data = d;
	mark = m;
}
string ispit::get_name_student() {
	return name_student;
}
int ispit::get_data() {
	return data;
}
int ispit::get_mark() {
	return mark;
}
void ispit::print() {
	cout << "i�'� ��������: " << setw(20) << name_student << endl;
	cout << "���� ��������i�: " << setw(19) << data << endl;
	cout << "������: " << setw(27) << mark << endl;
}