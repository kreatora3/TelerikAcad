function sixthTask(){
    var books,
        result,
        toPrint = String();

    books = [
    { author: 'Author#1',
      numberOfBooks: 5},

    { author: 'Author#2',
        numberOfBooks: 7},

    { author: 'Author#3',
        numberOfBooks: 1},

    { author: 'Author#4',
        numberOfBooks: 15}
        ]

    result = _.max(books, function(book){
        return book.numberOfBooks
    })

    toPrint = result.author + ' is the most popular due to his ' + result.numberOfBooks + ' books'
    $('#result6').slideToggle(toPrint).html(toPrint)
}

$('#result6').hide()
$('#result6executor').on('click', sixthTask)