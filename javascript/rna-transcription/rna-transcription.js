function DnaTranscriber() {}

DnaTranscriber.prototype = {
  toRna: function(dna) {
    var rna = dna
    rna = rna.replace(/C/g, 'g')
    rna = rna.replace(/G/g, 'c')
    rna = rna.replace(/A/g, 'u')
    rna = rna.replace(/T/g, 'a')
    return (rna = rna.toUpperCase())
  }
}

module.exports = DnaTranscriber
