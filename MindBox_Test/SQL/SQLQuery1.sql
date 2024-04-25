select products.NameProduct [Name Product], categorie.NameCategory [Name Category]
from Products products
LEFT join Categories categorie on products.IdCategory = categorie.id
order by categorie.NameCategory