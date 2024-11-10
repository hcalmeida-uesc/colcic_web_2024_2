#include <emscripten/emscripten.h>

EMSCRIPTEN_KEEPALIVE
const char* hello() {
    return "Hello, world from Assembly!";
}

int factorial(int n) {
    if (n <= 1) return 1;
    else return n * factorial(n - 1);
}
