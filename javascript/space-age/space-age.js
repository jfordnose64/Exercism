//
// This is only a SKELETON file for the 'Space Age' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

const EARTH_ORBITAL_PERIOD_SECONDS = 31557600

const ORBITALS_PERIOD_RATES = {
  earth: 1,
  mercury: 0.2408467,
  venus: 0.61519726,
  mars: 1.8808158,
  jupiter: 11.862615,
  saturn: 29.447498,
  uranus: 84.016846,
  neptune: 164.79132
}

export const age = (planet, seconds) => {
  const periodInSeconds =
    ORBITALS_PERIOD_RATES[planet] * EARTH_ORBITAL_PERIOD_SECONDS
  return parseFloat((seconds / periodInSeconds).toFixed(2))
}
