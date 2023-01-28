$("#submitButton").click(function () { //Receive values of the form onclick of the submit button
    assignments = ($("#assignments").val()) * .5
    group = ($("#groupProject").val()) * .1
    quizzes = ($("#quizzes").val()) * .1
    midterm = ($("#midtermExam").val()) * .1
    final = ($("#finalExam").val()) * .1
    INTEX = ($("#INTEX").val()) * .1

    //Calculate Overall %
    output = assignments + group + quizzes + midterm + final + INTEX

    //Calculate what Grade letter they received
    if (output >= 94) {
        outputLetter = 'A'
    }
    else if (output >= 90) {
        outputLetter = 'A-'
    }
    else if (output >= 87) {
        outputLetter = 'B+'
    }
    else if (output >= 84) {
        outputLetter = 'B'
    }
    else if (output >= 80) {
        outputLetter = 'B-'
    }
    else if (output >= 77) {
        outputLetter = 'C+'
    }
    else if (output >= 74) {
        outputLetter = 'C'
    }
    else if (output >= 70) {
        outputLetter = 'C-'
    }
    else if (output >= 67) {
        outputLetter = 'D+'
    }
    else if (output >= 64) {
        outputLetter = 'D'
    }
    else if (output >= 60) {
        outputLetter = 'D-'
    }
    else {
        outputLetter = 'E'
    }

    //output values to respective divs in index.html
    $("#outputPercent").text("Your overall grade percent is: " + output + "%")
    $("#outputLetter").text("Your letter grade is: " + outputLetter)

})