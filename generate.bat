@del dist /s/q
@swig -outdir "%cd%\dist" -c++ -cppext cc -csharp "%cd%\tinyxml2.i"
@pause