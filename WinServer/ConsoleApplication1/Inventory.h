#pragma once
#include "Item.h"

const int Inventory_MAX = 30;


class Inventory
{
	int inventory[Inventory_MAX];

	//mysql ���� �޾Ƽ� ����.
	//







public:
	Inventory();
	~Inventory();

	int Get(int index);
};

