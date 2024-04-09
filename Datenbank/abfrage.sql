
select b.name as brandName, b.description as brandDescription, m.name as modelName, m.production_year as productionYear, 
tp.name as tuningPartName, pb.name as tuningPartBrandName, pb.description as tuningPartBrandDescription, 
tpm.installation_time_minutes as installationTimeMin,
c.name as categoryName, c.description as categoryDescription
from tuning_parts_models tpm 
left join tuning_parts tp on tpm.part_id = tp.id 
left join models m on m.id = tpm.model_id
left join part_brands pb on pb.id = tp.brand_id 
left join categories c on c.id = tp.category_id
left join brands b on b.id = m.brand_id
order by 1;







