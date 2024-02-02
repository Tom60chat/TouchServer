#pragma once
#include "Network.h"

constexpr unsigned short int ECHO_PORT = 5560;
constexpr unsigned short int SERVER_PORT = 5559;

extern "C" __declspec(dllexport) void EchoThread();
extern "C" __declspec(dllexport) void EchoThreadA(IPv4 ip);
extern "C" __declspec(dllexport) void ServerThread();