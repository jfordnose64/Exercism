//
// This is only a SKELETON file for the 'Resistor Color Duo' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const decodedValue = resistorColor => {
  var color1 = 10 * COLORS.indexOf(resistorColor[0])
  var color2 = COLORS.indexOf(resistorColor[1])
  return color1 + color2
}

export const COLORS = [
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
]
