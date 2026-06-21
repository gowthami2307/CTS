SELECT e.title,
COUNT(CASE WHEN resource_type='pdf' THEN 1 END) pdf_count,
COUNT(CASE WHEN resource_type='image' THEN 1 END) image_count,
COUNT(CASE WHEN resource_type='link' THEN 1 END) link_count
FROM Events e
LEFT JOIN Resources r
ON e.event_id=r.event_id
GROUP BY e.title;