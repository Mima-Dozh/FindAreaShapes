create table poduct_table
(
    id int,
    product nvarchar(100)
)

create table category_table
(
    id int,
    category nvarchar(100)
)

create table maping_product_category
(
    -- Можно тут было сделать уникальные поля токда в запросе можно будет просто 
    id int,
    id_product int,
    id_category int,
)

select distinct id_product, id_category from maping_product_category;