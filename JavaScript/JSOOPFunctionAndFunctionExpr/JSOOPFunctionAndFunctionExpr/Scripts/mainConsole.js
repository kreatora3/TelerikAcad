(function () {
    specialConsole.writeLine('Just a message ... no placeholders'); 
   
    specialConsole.writeLine('A {0} with two {1}', 'message', 'placeholders'); 

    specialConsole.writeError('Error message: {0}', ' --> Error');
    specialConsole.writeWarning('Warning: {0}', 'Warning message')
}());