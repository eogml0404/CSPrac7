#include <iostream>
#include <cstring>

//using namespace std;
//const int SIZE = 8;
//
//struct Time {
//    int hours;
//    int mins;
//};
//
//const int minsPerHr = 60;
//
//void countDown(int n);
//Time sum(Time*, Time*);
//void showTime(Time);
//int sumArr(int* begin, int* end);
//void cheers(int n);
//float circle(int x);
//void helloCPP(int n, int m);
//
//int main() {
//    // ���� ���� �ִ� Ÿ��
//    cout << "���� ���̴� " << circle(3) << "�Դϴ�\n";
//
//    // ���� ���� ���� Ÿ��
//    cheers(3);
//    helloCPP(5, 3);
//
//    int arr[SIZE] = { 1, 2, 4, 8, 16, 32, 64, 128 };
//    Time day1 = { 5, 45 };
//    Time day2 = { 4, 55 };
//
//    Time total = sum(&day1, &day2);
//
//    cout << "��Ʋ�� �ҿ� �ð� : ";
//    showTime(total);
//    countDown(5);
//
//    return 0;
//}
//
//void cheers(int n) {
//    for (int i = 0; i < n; i++) {
//        cout << "Cheers!" << endl;
//    }
//}
//
//float circle(int x) {
//    return x * x * 3.14;
//}
//
//void helloCPP(int n, int m) {
//    for (int i = 0; i < n; i++)
//        cout << "Hello\n";
//
//    for (int i = 0; i < m; i++)  // ���⸦ �����߽��ϴ�
//        cout << "C++\n";
//}
//
//int sumArr(int* begin, int* end) {
//    int total = 0;
//    int* pt;
//
//    for (pt = begin; pt != end; pt++)
//        total += *pt;
//
//    return total;
//}
//
//Time sum(Time* t1, Time* t2) {
//    Time total;
//    total.mins = (t1->mins + t2->mins) % minsPerHr;
//    total.hours = t1->hours + t2->hours + (t1->mins + t2->mins) / minsPerHr;
//    return total;
//}
//
//void showTime(Time t1) {
//    cout << t1.hours << "�ð�, " << t1.mins << "�� �Դϴ�." << endl;
//}
//
////����Լ�
//void countDown(int n) {
//
//    cout << "counting.." << n << endl;
//    if (n > 0)
//        countDown(n - 1);
//    cout << n << "���� ����Լ�" << endl;
//
//}
