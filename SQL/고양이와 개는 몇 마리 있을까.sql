-- 고양이와 개는 몇 마리 있을까
SELECT ANIMAL_TYPE, COUNT(ANIMAL_TYPE) FROM ANIMAL_INS
WHERE ANIMAL_TYPE IN ('CAT', 'DOG')
GROUP BY ANIMAL_TYPE ORDER BY ANIMAL_TYPE;