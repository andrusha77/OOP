#pragma once
#include <iostream>
#include <string>
using namespace std;
class ispit {
	string name_student;
	int data;
	int mark;
public:
	ispit();
	ispit(string name_student, int data, int mark);
	ispit(const ispit&);
	~ispit(void);
	void set_name_student(string name_student);
	void set_data(int data);
	void set_mark(int mark);
	void setperson(string name_student, int data, int mark);
	string get_name_student();
	int get_data();
	int get_mark();
	void print();
};