// Рыжов Виталий Романович УИС-312
#include <iostream>
#include <Windows.h>
#include <vector>
#include <algorithm>
#include <iostream>
#include <conio.h>
#define KEY_UP 72
#define KEY_DOWN 80
#define KEY_LEFT 75
#define KEY_RIGHT 77
using namespace std;
int R = 100;
int delay_ms = 1000;
int r_contr = R;
int input_code = 0;
void printInfo(char key, DWORD threadId, DWORD start, DWORD end, int buffer) {
    cout << "================" << endl;
    cout << "Клавиша нажата: "; // в таблице аски 75 - K, а 77 - M
    if (key == 75) 
    {cout << "<-"<< endl;}
    else
    {cout << "->" << endl;}
    cout << "Идентификатор потока: " << threadId << endl;
    cout << "Клавиша нажата в: " << start << "мс" << endl;
    cout << "Поток завершен в: " << end << "мс" << endl;
    cout << "Общая переменная R: " << R << endl;
    cout << "================" << endl;
}
DWORD WINAPI processArrow(LPVOID lpParam)
{
    DWORD start = GetTickCount();
    int buffer = R;
    if (input_code == 75)
    {
        buffer++; 
    }
    else
    {
        buffer--;
    }
    R = buffer;
    Sleep(delay_ms);
    DWORD end = GetTickCount();
    printInfo(input_code, GetCurrentThreadId(), start, end, buffer);
    return 0;
}
int main(int argc, char* argv[])
{
    setlocale(LC_ALL, "Russian");
    cout << "Введите задержку: ";
    cin >> delay_ms;
    cout << "Вы ввели задержку: " << delay_ms << " мс" << std::endl;
    while (true) {
        input_code = _getch();
        if (input_code == 75 || input_code == 77)
        {
            if (input_code == 75)
            {
                r_contr++;

            }else
            {
                r_contr--;
            }
            cout << "================" << endl;
            cout << "Переменная дублер: " << r_contr << endl;
            cout << "Клавиша нажата: "; 
            if (input_code == 75)
            {
                cout << "<-" << endl;
            }
            else
            {
                cout << "->" << endl;
            }
            cout << "================" << endl;
            DWORD threadId;
            HANDLE threadHandle = CreateThread(NULL, 0, processArrow, NULL, 0, &threadId);
        }
    }
    return 0;
}