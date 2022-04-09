#include <windows.h>
#include <string>
#include <iostream>
using namespace std;
bool clicking;
int a;
int b;
int c;
int d;
HWND hWnd;
LPPOINT hon;
int delay = 2;

static void startclicker()
{
	INPUT input = { 0 };
	input.type = INPUT_MOUSE;
	ScreenToClient(hWnd, hon);
	while (true)
	{
		if (GetAsyncKeyState('Z'))
		{
			Sleep(100);
			POINT cursorPos;
			SendInput(1, &input, sizeof(input));
			GetCursorPos(&cursorPos);
			a = cursorPos.x;
			b = cursorPos.y;
			cout << "Mouse X1 = " << a << endl;
			cout << "Mouse Y1 = " << b << endl;

		}
		if (GetAsyncKeyState('X'))
		{
			Sleep(100);
			POINT cursorPos;
			SendInput(1, &input, sizeof(input));
			GetCursorPos(&cursorPos);
			c = cursorPos.x;
			d = cursorPos.y;
			cout << "Mouse X2 = " << c << endl;
			cout << "Mouse Y2 = " << d << endl;
		}
		if (GetAsyncKeyState(VK_ESCAPE))
		{
			cout << "======================================================" << endl << endl;
			cout << "EZ SHIPHAI " << endl;
			Sleep(1000);
			exit(1);
		}
		if (GetAsyncKeyState('C'))
		{
			cout << "Clicking !" << endl;
			Sleep(200);
			clicking = true;

			while (true)
			{

				if (!clicking)
				{
					break;
				}

				Sleep(delay * 1000);
				input.mi.dwFlags = SetCursorPos(a, b);
				mouse_event(MOUSEEVENTF_LEFTDOWN, a, b, 0, 0);
				mouse_event(MOUSEEVENTF_LEFTUP, a, b, 0, 0);
				SendInput(1, &input, sizeof(input));

				Sleep(delay * 1000);
				INPUT input = { 0 };
				input.mi.dwFlags = SetCursorPos(c, d);
				mouse_event(MOUSEEVENTF_LEFTDOWN, c, d, 0, 0);
				mouse_event(MOUSEEVENTF_LEFTUP, c, d, 0, 0);
				SendInput(1, &input, sizeof(input));


				if (GetAsyncKeyState('V'))
				{
					clicking = false;
					cout << "Stopping the clicker.." << endl;
				}

				if (GetAsyncKeyState(VK_ESCAPE))
				{
					cout << "======================================================" << endl << endl;
					cout << "EZ SHIPHAI " << endl;
					Sleep(1000);
					exit(1);
				}
			}
		}
	}
}

static void init()
{
	clicking = false;
	cout << endl;
	cout << "===================== EZ PLINKO =====================" << endl <<endl;
	cout << "   [ HOTKEYS ]" << endl << endl;
	cout << "   Z = save mouse position 1" << endl;
	cout << "   X = save mouse position 2" << endl;
	cout << "   C = activate autoclicker on saved position" << endl;
	cout << "   V = STOP" << endl;
	cout << "   ESC  = Close Program" << endl <<endl;
	cout << "======================================================" << endl <<endl;
}

static void LOG()
{
	cout << "======================================================" << endl << endl;
	cout << "[ LOG ] " << endl << endl;
	startclicker();
}



int main()
{
	init();
	cout << "   Input delay for mouse click (default is 2) : ";
	cin >> delay;
	cout << endl;
	LOG();
}

