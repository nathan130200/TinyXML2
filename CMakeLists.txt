cmake_minimum_required(VERSION 3.20)

project("tinyxml2")

add_library(cstinyxml2 SHARED
    "tinyxml2_wrap.cc"
    "tinyxml2_wrap.h"
    "tinyxml2.cc"
    "tinyxml2.h"
)
