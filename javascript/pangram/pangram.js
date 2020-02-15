var Pangram = function(string) {
  this.string = string.toLowerCase()
}

Pangram.prototype.isPangram = function() {
  var alphabet = 'abcdefghijklmnopqrstuvwxyz'

  // Initialises a string with all the alphabets
  var sentence = this.string

  // Iterate through the sentence and each for each letter, remove it from the array.
  for (var i = 0; i < sentence.length; i++) {
    // Find the index of the letter in array to delete
    var num = alphabet.indexOf(sentence[i])

    //If the letter is present in the array, remove it
    if (sentence[i] == alphabet[num]) {
      alphabet = alphabet.replace(sentence[i], '')
    }
  }

  if (alphabet.length == 0) {
    return true
  } else {
    return false
  }
}

module.exports = Pangram
