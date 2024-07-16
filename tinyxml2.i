%module(directors="1") "cstinyxml2"

%include "cstring.i"
%include "std_string.i"

%feature("director") XMLVisitor;
%include "tinyxml2.h"

%{
	#include "tinyxml2.h"
%}
