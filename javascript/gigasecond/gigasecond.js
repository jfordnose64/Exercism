//
// This is only a SKELETON file for the 'Gigasecond' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const gigasecond = startDate => {
  var startDate = startDate.getTime()
  var endDate = new Date(startDate + 1000000000000)
  return endDate
}
