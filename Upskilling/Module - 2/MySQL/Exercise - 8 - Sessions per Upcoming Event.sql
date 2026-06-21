SELECT e.title,
COUNT(s.session_id) AS total_sessions
FROM Events 
LEFT JOIN Sessions s
ON e.event_id=s.event_id
WHERE e.start_date > CURDATE()
GROUP BY e.title;