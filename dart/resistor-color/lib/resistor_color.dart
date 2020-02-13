class ResistorColor {
  List<String> colors = [
    'black',
    'brown',
    'red',
    'orange',
    'yellow',
    'green',
    'blue',
    'violet',
    'grey',
    'white'
  ];

  int colorcode(String color) {
    return colors
        .asMap()
        .keys
        .firstWhere((k) => colors[k] == color, orElse: () => null);
  }
}
