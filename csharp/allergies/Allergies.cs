using System;

[Flags]
public enum Allergen
{
  Eggs = 1,
  Peanuts = 2,
  Shellfish = 4,
  Strawberries = 8,
  Tomatoes = 16,
  Chocolate = 32,
  Pollen = 64,
  Cats = 128
}

public class Allergies
{
  private Allergen allergen { get; }

  public Allergies(int mask)
  {
    allergen = (Allergen)mask;
  }

  public bool IsAllergicTo(Allergen value)
  {
    return ((allergen & value) == value);
  }

  public Allergen[] List()
  {
    if (allergen == 0)
      return new Allergen[] { };

    var list = new System.Collections.Generic.List<Allergen>();

    if ((allergen & Allergen.Eggs) == Allergen.Eggs)
      list.Add(Allergen.Eggs);
    if ((allergen & Allergen.Peanuts) == Allergen.Peanuts)
      list.Add(Allergen.Peanuts);
    if ((allergen & Allergen.Shellfish) == Allergen.Shellfish)
      list.Add(Allergen.Shellfish);
    if ((allergen & Allergen.Strawberries) == Allergen.Strawberries)
      list.Add(Allergen.Strawberries);
    if ((allergen & Allergen.Tomatoes) == Allergen.Tomatoes)
      list.Add(Allergen.Tomatoes);
    if ((allergen & Allergen.Chocolate) == Allergen.Chocolate)
      list.Add(Allergen.Chocolate);
    if ((allergen & Allergen.Pollen) == Allergen.Pollen)
      list.Add(Allergen.Pollen);
    if ((allergen & Allergen.Cats) == Allergen.Cats)
      list.Add(Allergen.Cats);

    return list.ToArray();
  }
}