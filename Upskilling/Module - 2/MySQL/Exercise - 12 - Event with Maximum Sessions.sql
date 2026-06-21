SELECT e.title,
COUNT(s.session_id) total_sessions
FROM Events e
JOIN Sessions s
ON e.event_id=s.event_id
GROUP BY e.event_id,e.title
HAVING COUNT(s.session_id)=(
SELECT MAX(session_count)
FROM(
SELECT COUNT(*) session_count
FROM Sessions
GROUP BY event_id
)x
);